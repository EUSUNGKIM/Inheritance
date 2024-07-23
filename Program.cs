using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace 김의성_플밍1기__상속
{
    public class Program
    {
        public class Dummy
        {
            public string name;
            public int hp;

            public Dummy()
            {
                name = "더미인형";
                hp = 100;
            }
        }
        public class Firearms : Dummy
        {
            public string gunname;
            public string type;
            public int attack;

            public Firearms()
            {
                gunname = "M4";
                type = "돌격소총";
                attack = 55;
            }
            public virtual void GunAttack(int attack)
            {
                hp -= this.attack;
                Console.WriteLine($"{gunname}이 {this.attack}데미지로 맞췄습니다.");
                Console.WriteLine($"더미의 체력은{hp}남았습니다.");
                if (hp <= 0)
                {
                    Console.WriteLine($"{name}이 쓰러졌습니다.");
                }
            }
        }
        public class Ak47 : Firearms
        {
            public Ak47()
            {
                gunname = "AK47";
                type = "반자동 소총";
                attack = 65;
            }
        }
        public class M4 : Firearms
        {
            public M4()
            {
                
            }
        }
        public class Knife : Firearms
        {
            public Knife()
            {
                gunname = "나이프";
                type = "근접 무기";
                attack = 100;
            }

            public override void GunAttack(int attack)
            {
                hp -= this.attack;
                Console.WriteLine($"{gunname}이 {this.attack}데미지로 찔렀습니다.");
                Console.WriteLine($"더미의 체력은{hp}남았습니다.");
                if (hp <= 0)
                {
                    Console.WriteLine($"{name}이 쓰러졌습니다.");
                }
            }
        }

        static void Main(string[] args)
        {
            Ak47 ak47 = new Ak47();
            ak47.GunAttack(0);
            
            M4 m4 = new M4();
            m4.GunAttack(0);

            Knife knife = new Knife();
            knife.GunAttack(0);
        }
    }
}