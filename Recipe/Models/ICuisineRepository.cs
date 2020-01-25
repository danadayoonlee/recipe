using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSystem.Models
{
    public interface ICuisineRepository
    {
        IQueryable<Cuisine> Cuisines { get; }

        void SaveCuisine(Cuisine cuisine);

        Cuisine DeleteCuisine(int cuisineId);
    }
}
