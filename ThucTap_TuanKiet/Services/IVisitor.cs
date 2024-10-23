﻿using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IVisitor
    {
        public IEnumerable<Visitor> GetVisitorByIdViSc(int idViSc);
        public Visitor Add(int idAcc, int idViSc);
    }
}
