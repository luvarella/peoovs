﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace escolhinha
{
    static class NTurma
    {
        // private Turma[] turmas = new Turma[10];
        private static List<Turma> turmas = new List<Turma>();
        public static void Inserir(Turma t)
        { // C - Create
            Abrir();
            turmas.Add(t);
            Salvar();
        }
        public static Turma Listar(int id)
        {
            foreach (Turma obj in turmas)
                if (obj.Id == id) return obj;
            return null;
        }
        public static List<Turma> Listar()
        { // R - Read
            return turmas;
        }
        public static void Atualizar(Turma t)
        { // U - Update
            Abrir();
            Turma obj = Listar(t.Id);
            obj.Curso = t.Curso;
            obj.Descricao = t.Descricao;
            obj.AnoLetivo = t.AnoLetivo;
            Salvar();
        }
        public static void Excluir(Turma t)
        { // D - Delete
            Abrir();
            turmas.Remove(Listar(t.Id));
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
                f = new StreamReader("./turma.xml");
                turmas = (List<Turma>)xml.Deserialize(f);
                f.Close();
            }
            catch
            {
                turmas = new List<Turma>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
            StreamWriter f = new StreamWriter("./turma.xml", false);
            xml.Serialize(f, turmas);
            f.Close();
        }
    }
}
