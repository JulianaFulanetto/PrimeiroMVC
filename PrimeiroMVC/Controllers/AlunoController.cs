using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Robsinho da Silva", "rosinho.silva@sp.senai.br", 12345);
            Aluno a2 = new Aluno(1, "Cleiton Ronivaldo", "cleiton.roni@sp.senai.br", 56321);
            Aluno a3 = new Aluno(1, "Jeremias Ratinni", "jeremias.ratin@sp.senai.br", 98643);
            Aluno a4 = new Aluno(1, "Sorocaba Almeida", "sorocaba.almeida@sp.senai.br", 95374);
            Aluno a5 = new Aluno(1, "Fernandin Leme", "@fernandun.leme@sp.senai.br", 99872);

            //criar uma lista de alunos
            List<Aluno> listaAluno = new List<Aluno>();
            //Adicionando os obj alunos na lista alunos 
            listaAluno.Add(a1);
            listaAluno.Add(a2);
            listaAluno.Add(a3);
            listaAluno.Add(a4);
            listaAluno.Add(a5);

            //enviando a lista de alunos por parametro na view index 
            return View(listaAluno);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
