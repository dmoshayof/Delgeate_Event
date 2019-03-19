using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public class FunctionsContainer
    {
        private Dictionary<string, Func<double, double>> funcPairs { get; set; }

        public FunctionsContainer()
        {
            funcPairs = new Dictionary<string, Func<double, double>>();
        }

        public Func<double,double> this[string name]
        {
            get {
                if (funcPairs.ContainsKey(name)){
                    return funcPairs[name];
                }
                else
                {
                    return val=> val;
                }

                }
            
            set => funcPairs[name] = value;

        }


        public IList<string> getAllMissions()
        {
            IList<string> keys = funcPairs.Keys.ToList();
            return keys;
        }
    }
}
