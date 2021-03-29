using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.SeriesAndMovies
{
    public interface IRepositorio<T>
    {
        List<T> List();
        T RetornaPorId(int Id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T identidade);
        int ProximoId();
    }
}
