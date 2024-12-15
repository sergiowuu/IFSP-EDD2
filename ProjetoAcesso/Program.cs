using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ControleAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Download();

            int opcao;

            do
            {
                Console.WriteLine("Menu de Opções:");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar ambiente");
                Console.WriteLine("2. Consultar ambiente");
                Console.WriteLine("3. Excluir ambiente");
                Console.WriteLine("4. Cadastrar usuário");
                Console.WriteLine("5. Consultar usuário");
                Console.WriteLine("6. Excluir usuário");
                Console.WriteLine("7. Conceder permissão de acesso ao usuário");
                Console.WriteLine("8. Revogar permissão de acesso ao usuário");
                Console.WriteLine("9. Registrar acesso");
                Console.WriteLine("10. Consultar logs de acesso");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        cadastro.AdicionarAmbiente();
                        break;
                    case 2:
                        cadastro.ConsultarAmbiente();
                        break;
                    case 3:
                        cadastro.RemoverAmbiente();
                        break;
                    case 4:
                        cadastro.AdicionarUsuario();
                        break;
                    case 5:
                        cadastro.ConsultarUsuario();
                        break;
                    case 6:
                        cadastro.RemoverUsuario();
                        break;
                    case 7:
                        cadastro.ConcederPermissao();
                        break;
                    case 8:
                        cadastro.RevogarPermissao();
                        break;
                    case 9:
                        cadastro.RegistrarAcesso();
                        break;
                    case 10:
                        cadastro.ConsultarLogs();
                        break;
                    case 0:
                        cadastro.Upload();
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }
    }

    class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Ambiente> Ambientes { get; set; } = new List<Ambiente>();

        public bool ConcederPermissao(Ambiente ambiente)
        {
            if (!Ambientes.Contains(ambiente))
            {
                Ambientes.Add(ambiente);
                return true;
            }
            return false;
        }

        public bool RevogarPermissao(Ambiente ambiente)
        {
            return Ambientes.Remove(ambiente);
        }
    }

    class Ambiente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Queue<Log> Logs { get; set; } = new Queue<Log>();

        public void RegistrarLog(Log log)
        {
            if (Logs.Count >= 100)
            {
                Logs.Dequeue();
            }
            Logs.Enqueue(log);
        }
    }

    class Log
    {
        public DateTime DtAcesso { get; set; }
        public Usuario Usuario { get; set; }
        public bool TipoAcesso { get; set; } // true = autorizado, false = Nego
    }

    class Cadastro
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Ambiente> ambientes = new List<Ambiente>();
        private string connectionString = "Server=localhost;Database=ControleAcesso;Uid=root;Pwd=;";

        public void AdicionarUsuario()
        {
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            Usuario usuario = new Usuario { Nome = nome };
            usuarios.Add(usuario);
            Console.WriteLine("Usuário cadastrado com sucesso.");
        }

        public void ConsultarUsuario()
        {
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            Usuario usuario = usuarios.Find(u => u.Nome == nome);
            if (usuario != null)
            {
                Console.WriteLine($"Usuário encontrado: {usuario.Nome}");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }

        public void RemoverUsuario()
        {
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            Usuario usuario = usuarios.Find(u => u.Nome == nome);
            if (usuario != null && usuario.Ambientes.Count == 0)
            {
                usuarios.Remove(usuario);
                Console.WriteLine("Usuário removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Usuário não pode ser removido.");
            }
        }

        public void AdicionarAmbiente()
        {
            Console.Write("Digite o nome do ambiente: ");
            string nome = Console.ReadLine();
            Ambiente ambiente = new Ambiente { Nome = nome };
            ambientes.Add(ambiente);
            Console.WriteLine("Ambiente cadastrado com sucesso.");
        }

        public void ConsultarAmbiente()
        {
            Console.Write("Digite o nome do ambiente: ");
            string nome = Console.ReadLine();
            Ambiente ambiente = ambientes.Find(a => a.Nome == nome);
            if (ambiente != null)
            {
                Console.WriteLine($"Ambiente encontrado: {ambiente.Nome}");
            }
            else
            {
                Console.WriteLine("Ambiente não encontrado.");
            }
        }

        public void RemoverAmbiente()
        {
            Console.Write("Digite o nome do ambiente: ");
            string nome = Console.ReadLine();
            Ambiente ambiente = ambientes.Find(a => a.Nome == nome);
            if (ambiente != null)
            {
                ambientes.Remove(ambiente);
                Console.WriteLine("Ambiente removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Ambiente não encontrado.");
            }
        }

        public void ConcederPermissao()
        {
            Console.Write("Digite o nome do usuário: ");
            string nomeUsuario = Console.ReadLine();
            Usuario usuario = usuarios.Find(u => u.Nome == nomeUsuario);

            Console.Write("Digite o nome do ambiente: ");
            string nomeAmbiente = Console.ReadLine();
            Ambiente ambiente = ambientes.Find(a => a.Nome == nomeAmbiente);

            if (usuario != null && ambiente != null)
            {
                if (usuario.ConcederPermissao(ambiente))
                {
                    Console.WriteLine("Permissão concedida.");
                }
                else
                {
                    Console.WriteLine("Usuário já possui permissão para este ambiente.");
                }
            }
            else
            {
                Console.WriteLine("Usuário ou ambiente não encontrado.");
            }
        }

        public void RevogarPermissao()
        {
            Console.Write("Digite o nome do usuário: ");
            string nomeUsuario = Console.ReadLine();
            Usuario usuario = usuarios.Find(u => u.Nome == nomeUsuario);

            Console.Write("Digite o nome do ambiente: ");
            string nomeAmbiente = Console.ReadLine();
            Ambiente ambiente = ambientes.Find(a => a.Nome == nomeAmbiente);

            if (usuario != null && ambiente != null)
            {
                if (usuario.RevogarPermissao(ambiente))
                {
                    Console.WriteLine("Permissão revogada.");
                }
                else
                {
                    Console.WriteLine("Usuário não possui permissão para este ambiente.");
                }
            }
            else
            {
                Console.WriteLine("Usuário ou ambiente não encontrado.");
            }
        }

        public void RegistrarAcesso()
        {
            Console.Write("Digite o nome do usuário: ");
            string nomeUsuario = Console.ReadLine();
            Usuario usuario = usuarios.Find(u => u.Nome == nomeUsuario);

            Console.Write("Digite o nome do ambiente: ");
            string nomeAmbiente = Console.ReadLine();
            Ambiente ambiente = ambientes.Find(a => a.Nome == nomeAmbiente);

            if (usuario != null && ambiente != null)
            {
                bool autorizado = usuario.Ambientes.Contains(ambiente);
                ambiente.RegistrarLog(new Log { DtAcesso = DateTime.Now, Usuario = usuario, TipoAcesso = autorizado });
                Console.WriteLine(autorizado ? "Acesso autorizado." : "Acesso negado.");
            }
            else
            {
                Console.WriteLine("Usuário ou ambiente não encontrado.");
            }
        }

        public void ConsultarLogs()
        {
            Console.Write("Digite o nome do ambiente: ");
            string nomeAmbiente = Console.ReadLine();
            Ambiente ambiente = ambientes.Find(a => a.Nome == nomeAmbiente);

            if (ambiente != null)
            {
                Console.WriteLine("Filtrar logs por:");
                Console.WriteLine("1. Autorizados");
                Console.WriteLine("2. Negados");
                Console.WriteLine("3. Todos");
                Console.Write("Escolha uma opção: ");
                int filtro = int.Parse(Console.ReadLine());

                foreach (var log in ambiente.Logs)
                {
                    if (filtro == 1 && log.TipoAcesso || filtro == 2 && !log.TipoAcesso || filtro == 3)
                    {
                        Console.WriteLine($"Data: {log.DtAcesso}, Usuário: {log.Usuario.Nome}, Tipo: {(log.TipoAcesso ? "Autorizado" : "Negado")}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ambiente não encontrado.");
            }
        }

        public void Upload()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

               
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Logs; DELETE FROM Permissoes; DELETE FROM Usuarios; DELETE FROM Ambientes;", conn);
                cmd.ExecuteNonQuery();

               
                foreach (var ambiente in ambientes)
                {
                    cmd = new MySqlCommand("INSERT INTO Ambientes (Nome) VALUES (@Nome);", conn);
                    cmd.Parameters.AddWithValue("@Nome", ambiente.Nome);
                    cmd.ExecuteNonQuery();
                    ambiente.Id = (int)cmd.LastInsertedId;
                }

                
                foreach (var usuario in usuarios)
                {
                    cmd = new MySqlCommand("INSERT INTO Usuarios (Nome) VALUES (@Nome);", conn);
                    cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                    cmd.ExecuteNonQuery();
                    usuario.Id = (int)cmd.LastInsertedId;

                    foreach (var ambiente in usuario.Ambientes)
                    {
                        cmd = new MySqlCommand("INSERT INTO Permissoes (UsuarioId, AmbienteId) VALUES (@UsuarioId, @AmbienteId);", conn);
                        cmd.Parameters.AddWithValue("@UsuarioId", usuario.Id);
                        cmd.Parameters.AddWithValue("@AmbienteId", ambiente.Id);
                        cmd.ExecuteNonQuery();
                    }
                }

             
                foreach (var ambiente in ambientes)
                {
                    foreach (var log in ambiente.Logs)
                    {
                        cmd = new MySqlCommand("INSERT INTO Logs (DtAcesso, UsuarioId, AmbienteId, TipoAcesso) VALUES (@DtAcesso, @UsuarioId, @AmbienteId, @TipoAcesso);", conn);
                        cmd.Parameters.AddWithValue("@DtAcesso", log.DtAcesso);
                        cmd.Parameters.AddWithValue("@UsuarioId", log.Usuario.Id);
                        cmd.Parameters.AddWithValue("@AmbienteId", ambiente.Id);
                        cmd.Parameters.AddWithValue("@TipoAcesso", log.TipoAcesso);
                        cmd.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Dados persistidos no banco.");
            }
        }

            public void Download()
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    
                    MySqlCommand cmd = new MySqlCommand("SELECT Id, Nome FROM Ambientes;", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ambientes.Add(new Ambiente { Id = reader.GetInt32("Id"), Nome = reader.GetString("Nome") });
                        }
                    }

                    
                    cmd = new MySqlCommand("SELECT Id, Nome FROM Usuarios;", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(new Usuario { Id = reader.GetInt32("Id"), Nome = reader.GetString("Nome") });
                        }
                    }

                    
                    cmd = new MySqlCommand("SELECT UsuarioId, AmbienteId FROM Permissoes;", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = usuarios.Find(u => u.Id == reader.GetInt32("UsuarioId"));
                            Ambiente ambiente = ambientes.Find(a => a.Id == reader.GetInt32("AmbienteId"));
                            if (usuario != null && ambiente != null)
                            {
                                usuario.Ambientes.Add(ambiente);
                            }
                        }
                    }

                   
                    cmd = new MySqlCommand("SELECT DtAcesso, UsuarioId, AmbienteId, TipoAcesso FROM Logs;", conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = usuarios.Find(u => u.Id == reader.GetInt32("UsuarioId"));
                            Ambiente ambiente = ambientes.Find(a => a.Id == reader.GetInt32("AmbienteId"));
                            if (usuario != null && ambiente != null)
                            {
                                ambiente.RegistrarLog(new Log
                                {
                                    DtAcesso = reader.GetDateTime("DtAcesso"),
                                    Usuario = usuario,
                                    TipoAcesso = reader.GetBoolean("TipoAcesso")
                                });
                            }
                        }
                    }

                    Console.WriteLine("Dados carregados do banco.");
                }
            }
        }
    }
