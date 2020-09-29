﻿using CPSI.Negocio.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CPSI.Negocio.Interface
{
    public interface ITurmaRepository : IRepository<Turma>
    {
        Task<Turma> ObterTurma(int id);
        Task<List<Turma>> ObterTurmasComDisciplinas();
    }
}
