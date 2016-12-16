using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentsAndPasswords
{
    public class MI5Agent
    {


        public string SecretPassword = "LONDON";
        public string SecretAnswer = "TEXAS";
        public bool TrustOtherAgent = false;

        public string SaySecretGreeting()
        /// Назначение: вовзращает секретное приветствие и пишет его на консоли
        {
            Console.WriteLine("'" + SecretPassword + "' , " + this.ToString() + " says...");
            return SecretPassword;
        }

        public string CheckSecretGreeting(string agentSays)
        /// Назначение: получив от другого агента кодовое слово, наш агент решает, доверяет ли он ему
        /// На входе: тайное слово как строка
        /// На выходе: ответ агента - отзыв на код или "извините, вы обознались..."
        {

            // если пароль совпал...
            if (agentSays == SecretPassword)
            {
                // то доверять агенту = истина
                TrustOtherAgent = true;
                // и отвечаем ему кодовым словом
                Console.WriteLine("'OK!, and " + SecretAnswer + "', " + this.ToString() + " says...");
                return SecretAnswer;
            }

            else // иначе 
            {
                // естественно не доверяем ему
                TrustOtherAgent = false;
                // и прикинемся шлангом :)
                Console.WriteLine("'Sorry, you are looking for somebody else!..', " + this.ToString() + " says...");
                return "Sorry, you are looking for somebody else!..";
            }

        }

        public void CheckSecretAnswer(string agentSays)
        /// Назначение: проверяет секретный ответ и устанавливает ВеритьАгенту в ЛОЖЬ, если он врет
        /// Вход: слова агента как строка
        /// Выход: ничего, но меняет внутреннюю переменную TrustOtherAgent в ЛОЖЬ если он врет
        {
            // TODO: CheckSecretAnswer - добавь свой код здесь :)
            // если то что сказал другой агент НЕ РАВНО секретному ответу...

            // то тогда ВеритьАгенту = ЛОЖЬ

            // Обрати внимание - приходится добавлять метод в двух классах; раздражает, правда?..
        }

        public bool DoITrustYou()
        /// Назначение: сообщает, верит ли он второму агенту
        /// На входе: ничего, использует внутренние переменные класса
        /// На выходе: истина если верит, ложь если не верит
        {
            if (TrustOtherAgent) // это то же самое что (TrustOtherAgent == true)
            {
                Console.WriteLine("'OK, I do trust you!', " + this.ToString() + " says...");
                return true;
            }
            else
            {
                Console.WriteLine("'No, I do not trust you!', " + this.ToString() + " says...");
                return false;
            }
        }


    }
}

