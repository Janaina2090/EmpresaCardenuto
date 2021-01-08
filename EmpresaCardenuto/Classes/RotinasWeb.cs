using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using EmpresaCardenuto.Models;

namespace EmpresaCardenuto.Classes
{
    public class RotinasWeb
    {
       public static void GravarContato(Contatos contato)
        {
            string arquivo = HttpContext
                .Current
                .Server
                .MapPath("~/App_Data/Contatos.txt");

            using (var sw = new  StreamWriter(arquivo, true, Encoding.UTF8))
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(contato.Nome);
                sw.WriteLine(contato.Email);
                sw.WriteLine(contato.Assunto);
                sw.WriteLine(contato.Mensagem);
                sw.WriteLine(new string('-', 30));
            }
        }

        
                
        

                
        
    }
}