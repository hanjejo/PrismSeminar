using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publish_SubscribePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            scenario_animal();

            scenario_youtube();
        }

        static void scenario_animal()
        {
            //구독자 추가
            Dog dog = new Dog();
            Pig pig = new Pig();

            //알림요청
            EventAggregator.ProviderMachine.Subscribe(dog.Action);
            EventAggregator.ProviderMachine.Subscribe(pig.Action);

            //게시자 생성
            AnimalManager Manager = new AnimalManager();

            //Event 게시 요청
            Manager.HaveLunch();
        }

        static void scenario_youtube()
        {
            //공급자 생성
            Youtuber Jugealrum = new Youtuber();

            //구독자 추가
            Customer Hanje = new Customer();

            //알림요청
            EventAggregator.Jugealum_Youtube.Subscribe(Hanje.Action);

            //공급자 업로드 요청
            Jugealrum.NewContent("주식으로 500만원 만든 방법", "1000만원으로 시작한다.");
        }
    }

    public class Dog
    {
        public void Action()
        {
            Console.WriteLine("Dog : 감사 ㅎㅎ");
        }
    }

    public class Pig
    {
        public void Action()
        {
            Console.WriteLine("Pig : 감사 ㅎㅎ");
        }
    }

    public class AnimalManager
    {
        public void HaveLunch()
        {
            Console.WriteLine("사료공급");
            EventAggregator.ProviderMachine.Publish();
        }
    }

    public class Customer
    {
        public void Action(Contents content)
        {
            Console.WriteLine("제목 :" + content.Name + "가 업로드되었습니다.");
            Console.WriteLine("내용 :" + content.Text);
        }
    }

    public class Youtuber
    {
        public void NewContent(string contents, string Text)
        {
            //콘텐츠 생성
            Contents content = new Contents() { Name = contents, Text = Text };

            //콘텐츠 유투브 업로드
            //콘텐츠 발행
            EventAggregator.Jugealum_Youtube.Publish(content);
        }
    }
}
