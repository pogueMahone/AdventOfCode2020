using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Models.Day2
{    
    public class PasswordPolicy
    {
        
        private readonly MatchCollection _match_col = null;        
        public PasswordPolicy(string criteria)
        {
            var tmp1 = criteria.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            this.Input = tmp1[tmp1.Length - 1].Trim();
            var tmp2 = tmp1[0].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            this.Pattern = string.Format("[{0}]", tmp2[tmp2.Length - 1].Trim());
            var tmp3 = tmp2[0].Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            int.TryParse(tmp3[0], out int v1);
            int.TryParse(tmp3[tmp3.Length -1], out int v2);
            this.Vars = new MatchVariables(v1, v2);
            this._match_col = Regex.Matches(this.Input, this.Pattern);
        }

        public string Input { get; set; }
        public string Pattern { get; set; }
        public MatchVariables Vars { get; set; }        

       
        public bool ValidByRange
        {
            get
            {
               return this._match_col.Count >= this.Vars.Var1 && this._match_col.Count <= this.Vars.Var2;
            }
        }


        /// <summary>
        /// Subtract 1 from Match Variables b/c input values do not account for index 0  
        /// </summary>        
        public bool ValidByIndex
        {
            get 
            {
                var indexes = this._match_col.Count(o => o.Index == (this.Vars.Var1 - 1) || o.Index == (this.Vars.Var2 - 1));
                return indexes == 1;
            }
        }
    }

    public class MatchVariables 
    {
        public MatchVariables(int v1, int v2)
        {
            this.Var1 = v1;
            this.Var2 = v2;
        }
        public int Var1 { get; set; }
        public int Var2 { get; set; }
    }
}
