using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmetDotNetObjectiveRenan.Repositories
{
    public static class FakeData
    {
        public static string jsonFoodData = @"
        {
          ""foodGuess"": [
            {
              ""id"": 1,
              ""name"": ""macarrão"",
              ""tips"": [1, 2]
            },
            {
              ""id"": 2,
              ""name"": ""sushi"",
              ""tips"": [3, 4]
            },
            {
              ""id"": 3,
              ""name"": ""pizza"",
              ""tips"": [5, 6]
            },
            {
              ""id"": 4,
              ""name"": ""hambúrguer"",
              ""tips"": [7, 8]
            },
            {
              ""id"": 5,
              ""name"": ""sorvete"",
              ""tips"": [9, 10]
            },
            {
              ""id"": 6,
              ""name"": ""paella"",
              ""tips"": [11, 12]
            }
          ],
          ""tip"": [
            {
              ""id"": 1,
              ""name"": ""pasta""
            },
            {
              ""id"": 2,
              ""name"": ""origem italiana""
            },
            {
              ""id"": 3,
              ""name"": ""comida japonesa""
            },
            {
              ""id"": 4,
              ""name"": ""feito com peixe cru""
            },
            {
              ""id"": 5,
              ""name"": ""tem molho de tomate""
            },
            {
              ""id"": 6,
              ""name"": ""origem italiana""
            },
            {
              ""id"": 7,
              ""name"": ""pão com carne""
            },
            {
              ""id"": 8,
              ""name"": ""comida rápida""
            },
            {
              ""id"": 9,
              ""name"": ""sobremesa gelada""
            },
            {
              ""id"": 10,
              ""name"": ""feito com leite""
            },
            {
              ""id"": 11,
              ""name"": ""prato espanhol""
            },
            {
              ""id"": 12,
              ""name"": ""feito com arroz""
            }
          ]
        }";
    }
}
