      using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {

        public delegate double compodesDel(double value);
        private IList<compodesDel> missions;
        public string Name {get;}
        public string Type { get; }
        public ComposedMission( string name)
        {
            Name = name;
            Type = "Composed Mission";
            missions = new List<compodesDel>();
        }
        public ComposedMission Add(Func<double,double> func)
        {
            compodesDel del = new compodesDel(func);
            missions.Add(del);
            return this;
        }
       
        

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            
            foreach( var i in missions)
            {
                value = i.Invoke(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }

     
    }
}
