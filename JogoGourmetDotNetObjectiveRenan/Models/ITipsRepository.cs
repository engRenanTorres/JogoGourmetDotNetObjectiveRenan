using JogoGourmetDotNetObjectiveRenan.Model;
using JogoGourmetDotNetObjectiveRenan.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNetObjectiveRenan.Models
{
    public interface ITipsRepository
    {
        public List<Tip> Tips { get; set; }
        public Tip Get(int id);

        public IEnumerable<Tip> GetAll();
    }
}
