using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class VirtualPet
    {
        #region fields

        const string tamagotchi = ".~.\n   /V\\\n  // \\\\\n /(   )\\\n  ^`~'^";

        string ownersName;
        string petsName;
        int hungriness;
        int fullness;
        int happiness;
        int tiredness;
        string image;
        #endregion

        #region Constructors
        public VirtualPet()
        {

        }

        public VirtualPet(string ownersName, string petsName)
        {
            this.ownersName = ownersName;
            this.petsName = petsName;
        }

        public VirtualPet(int hungriness, int fullness, int happiness, int tiredness)
        {
            this.hungriness = hungriness;
            this.fullness = fullness;
            this.happiness = happiness;
            this.tiredness = tiredness;
        }
        #endregion

        #region properties
        public string OwnersName
        {
            get { return this.ownersName; }
            set { this.ownersName = value; }
        }

        public string Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

        public string TamagotchiImage
        {
            get { return tamagotchi; }
        }

        public string PetsName
        {
            get { return this.petsName; }
            set { this.petsName = value; }
        }

        public int Hungriness
        {
            get
            { return this.hungriness; }

            set
            {
                this.hungriness = value;
                if (this.hungriness < 0)
                {
                    this.hungriness = 0;
                }
                if (this.hungriness > 100)
                {
                    this.hungriness = 100;
                }
            }

        }
        public int Fullness
        {
            get { return this.fullness; }

            set
            {
                this.fullness = value;
                if (this.fullness < 0)
                {
                    this.fullness = 0;
                }
                if (this.fullness > 100)
                {
                    this.fullness = 100;
                }
            }
        }

        public int Happiness
        {
            get { return this.happiness; }

            set
            {
                this.happiness = value;
                if (this.happiness < 0)
                {
                    this.happiness = 0;
                }
                if (this.happiness > 100)
                {
                    this.happiness = 100;
                }
            }
        }

        public int Tiredness
        {
            get { return this.tiredness; }

            set
            {
                this.tiredness = value;
                if (this.tiredness < 0)
                {
                    this.tiredness = 0;
                }
                if (this.tiredness > 100)
                {
                    this.tiredness = 100;
                }
            }
        }

        public double PetSatisfaction
        {
            get { return 100 - ((this.Hungriness + this.Fullness + (100 - this.Happiness) + this.Tiredness) / 4); }

        }
        #endregion

        #region methods
        public void ShowPetStatus()
        {
            Console.WriteLine("{0} :", this.PetsName);
            Console.WriteLine("\tis {0}% hungry.", this.Hungriness);
            Console.WriteLine("\tis {0}% happy.", this.Happiness);
            Console.WriteLine("\tis {0}% tiredness.", this.Tiredness);
            Console.WriteLine("\tis {0}% full .", this.Fullness);
            Console.WriteLine();
        }

        public void FeedChoci()
        {
            this.Hungriness -= 10;
            this.Fullness += 10;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Yummy Chocolates!\"", this.PetsName);
        }

        public void FeedBiscuits()
        {
            this.Hungriness -= 10;
            this.Fullness += 10;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Tasty Bisuits!\"", this.PetsName);
        }

        public void FeedSweets()
        {
            this.Hungriness -= 10;
            this.Fullness += 10;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Too Sweet!\"", this.PetsName);
        }

        public void FeedFruits()
        {
            this.Hungriness -= 30;
            this.Fullness += 30;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Very Healthy!\"", this.PetsName);
        }

        public void SleepFive()
        {
            this.Tiredness -= 5;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Need more time to sleep!\"", this.PetsName);
        }

        public void SleepTen()
        {
            this.Tiredness -= 10;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Refreshing!\"", this.PetsName);
        }

        public void SleepFifteen()
        {
            this.Tiredness -= 15;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Feels more Refreshing!\"", this.PetsName);
        }

        public void SleepTwenty()
        {
            this.Tiredness -= 30;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} is , \"Dreaming!\"", this.PetsName);
        }

        public void Bathroom()
        {
            this.Fullness -= 60;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Aaaaah!\"", this.PetsName);
        }

        public void SpendTimeAlone()
        {
            this.Tiredness += 20;
            this.Hungriness += 20;
            this.Happiness -= 40;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} feels needy and waiting for you", this.PetsName);
        }

        public void PlayBall()
        {
            this.Tiredness += 10;
            this.Happiness += 10;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Throw the ball again\"", this.PetsName);
        }

        public void PlayRope()
        {
            this.Tiredness += 20;
            this.Happiness += 20;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"This is so much fun!\"", this.PetsName);
        }

        public void PlayRun()
        {
            this.Tiredness += 30;
            this.Happiness += 30;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Hurrayyy, I like Running with You {1}!\"", this.PetsName, this.OwnersName);
        }
        #endregion
    }
}