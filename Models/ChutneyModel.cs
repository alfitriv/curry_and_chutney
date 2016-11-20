using System;
using System.Collections.Generic;

namespace MYFIRSTAPP.Models
{
    public class ChutneyRecipes
    {
        public string Name {get; set;}
        public string Category {get; set;}
    }

    public class ChutneyRecipesDatabase : List<ChutneyRecipes>
    {
        public ChutneyRecipesDatabase()
        {
            Add (new ChutneyRecipes() {Name="Almond Chutney", Category="Chutney"});
            Add (new ChutneyRecipes() {Name="Sunflower Seeds Chutney", Category="Chutney"});
            Add (new ChutneyRecipes() {Name="Moong Dal Chutney", Category="Chutney"});
            Add (new ChutneyRecipes() {Name="Kandipappu", Category="Chutney"});
            Add (new ChutneyRecipes() {Name="Beet Root Leaves Chutney", Category="Chutney"});
            Add (new ChutneyRecipes() {Name="Tomato Perugu Chutney", Category="Chutney"});
            Add (new ChutneyRecipes() {Name="Vankaya Pachadi", Category="Chutney"});
            Add (new ChutneyRecipes() {Name="Dosakaya Pachadi", Category="Chutney"});
            Add (new ChutneyRecipes() {Name="Keera Dosakaya", Category="Chutney"});
        }
    }
}



