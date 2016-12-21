using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentsAndPasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // В этой программе происходит первая встреча Джеймса Бонда и Феликса Лейтера :)
            // Вот на площади появились два агента...

            MI5Agent JamesBond = new MI5Agent();
            CIAAgent FelixLeiter = new CIAAgent();

            // и Джеймс Бонд получает от Феликса Лейтера секретное приветствие и сохраняет в строку в голове... :) 
            string usAgentTold = "grovel";
            // и после этого проверяет его...
            JamesBond.CheckSecretAnswer(FelixLeiter.CheckSecretGreeting(usAgentTold));

            // после этого он говорит, верит ли он этому агенту
            JamesBond.DoITrustYou();

            // Теперь очередь Феликса Лейтера проверить Джеймса Бонда...
            // Он получает от Джеймса Бонда секретное приветствие...
            FelixLeiter.CheckSecretGreeting(JamesBond.SaySecretGreeting());
            // Обрати внимание: метод может получать на входе значение из другого метода!!! :)
            // после этого он говорит, верит ли он этому агенту
            FelixLeiter.DoITrustYou();

            /// ОКЕЙ, А ТЕПЕРЬ МЫ ВМЕШАЕМСЯ :)
            // TODO: А как же проверка "отзыва"? :) Можешь сделать проверку отзыва методом CheckSecretAnswer? (после строк 23 и 29)

            // HACK: А слабо говорить пароль, проверять пароль и проверять отзыв одной строкой? :)

            // HACK: Представь себе что ты агент КГБ :) Можешь вывести на экран пароли обоих агентов?

            JamesBond.SecretPassword = "lopata";
            Console.WriteLine(JamesBond.SecretPassword);
            Console.WriteLine(FelixLeiter.SecretAnswer);

            JamesBond.TrustOtherAgent = true;
            JamesBond.DoITrustYou();
            


            // HACK: Представь себе что ты агент КГБ :) А можно их заставить тебе верить без паролей? :)

            // HACK: Как думаешь, почему пароли и ключи видны всем?
            // HACK: Расставив ключи private & public сделай так, чтоб только они видели свои пароли

            Console.ReadKey();
        }
    }
}
