using JogoGourmetDotNetObjectiveRenan.Model;
using JogoGourmetDotNetObjectiveRenan.Models;
using JogoGourmetDotNetObjectiveRenan.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNetObjectiveRenan.Repository
{
    internal class TipsRepository: ITipsRepository
    {
        public List<Tip> Tips { get; set; } = new List<Tip>();
        public TipsRepository()
        {
            var jsonData = FakeData.jsonFoodData;
            var data = JsonConvert.DeserializeObject<FoodGuessData>(jsonData);
            Tips = data?.Tip;
        }
        public Tip Get(int id)
        {
            return Tips.Find(f => f.Id == id);
        }

        public IEnumerable<Tip> GetAll()
        {
            return Tips;
        }
    }
}
