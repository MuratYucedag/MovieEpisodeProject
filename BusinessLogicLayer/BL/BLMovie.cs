using EntityLayer.Entities;
using FacadeLayer.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.BL
{
    public class BLMovie
    {
        public static List<EntityMovie> BLMovieList()
        {
            return DALMovie.MovieList();
        }
        public void BLAddMovie(EntityMovie entityMovie)
        {
            if (entityMovie.Moviecountry != "" && entityMovie.Moviename.Length >= 5)
            {
                DALMovie.AddMovie(entityMovie);
            }
        }
        public void BLDeleteMovie(int id)
        {
            DALMovie.DeleteMovie(id);
        }
        public void BLUpdateMovie(EntityMovie entityMovie)
        {
            if (entityMovie.Moviecountry != "" && entityMovie.Moviename.Length >= 5 && entityMovie.Movieimage.Length >= 15)
            {
                DALMovie.UpdateMovie(entityMovie);
            }
        }
    }
}
