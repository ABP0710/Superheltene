using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheltene
{
    // A school assingment about classes
    //this is my class for the superheroes namend superheltene
    internal class Superheltene
    {
        //Variable whit the knowlage of the superheroes
        private string _HeroName;

        private string _secretIdentity;

        private string _superPower;

        private string _superSuite;

        private string _herosMotivation;

        private string _archenemy;

        private string _anxiety;

        //incabtulade
        public string HeroName
        {
            get { return _HeroName; }
            set { _HeroName = value; }
        }

        public string SecretIdentity
        {
            get { return _secretIdentity; }
            set { _secretIdentity = value; }
        }

        public string SuperPower
        {
            get { return _superPower; }
            set { _superPower = value; }
        }

        public string SuperSuite
        {
            get { return _superSuite; }
            set { _superSuite = value; }
        }

        public string HerosMotivation
        {
            get { return _herosMotivation; }
            set { _herosMotivation = value; }
        }

        public string Archenemy
        {
            get { return _archenemy; }
            set { _archenemy = value; }
        }

        public string Anxiety
        {
            get { return _anxiety; }
            set { _anxiety = value; }
        }

        //methoods, for the fun of it they write about spiderman
        private void HerosName()
        {
            Console.WriteLine("Spiderman");
        }

        private void WhoIsTheSecretIdentiy()
        {
            Console.WriteLine("Peter Parker");
        }

        private void UsePower()
        {
            Console.WriteLine("wep slinger, claiming walls and spidersence");
        }

        private void Costume()
        {
            Console.WriteLine("hes supersuite is red, white and blue");
        }

        private void Motivation()
        {
            Console.WriteLine("to revenge and honer hes dead unkel");
        }

        private void Nemasis()
        {
            Console.WriteLine("venom, doc Octopus, green Goblin ang the Kingpin");
        }

        private void Fear()
        {
            Console.WriteLine("he fears becomming a huge ugly spider");
        }
    }
}
