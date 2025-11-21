using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_patrones_en_CSharp.Singleton
{
    public class SessionManager
    {
        public static object _lock = new object();
        private static SessionManager smanager;
        Usuario _usuario;
        DateTime fechaSession;
        public Usuario Usuario { get => _usuario; set => _usuario = value; }
        public DateTime FechaSession { get => fechaSession; set => fechaSession = value; }
        
        public static SessionManager GetInstance
        {
            get {
                if (smanager == null) throw new Exception("no existe la session loguese primero");
                return smanager;
            }
        }

        public static void Login(Usuario usuario)
        {
            // esto nos permite realizar un bloqueo de los hilos
            lock (_lock)
            {
                if (smanager == null)
                {
                    smanager = new SessionManager();
                    smanager._usuario = usuario;
                    smanager.fechaSession = DateTime.Now;
                }
                else
                {
                    throw new Exception("error al momento de iniciar login");
                }
            }
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (smanager != null)
                {
                    smanager = null;
                }
                else
                {
                    throw new Exception("error session ya iniciada");
                }
            }
        }

        private SessionManager()
        {
            // constructor privado
        }


    }
}
