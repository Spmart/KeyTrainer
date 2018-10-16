using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibForKeyTrainer
{ 
    public class Stats
    {
        private int _total = 0;
        private int _missed = 0;
        private int _correct = 0;
        private int _accuracy = 0;

        //Методы, которые увеличивают значения на 1
        public void IncTotal()
        {
            _total++;
        }

        public void IncMissed()
        {
            _missed++;
        }

        public void IncCorrect()
        {
            _correct++;
        }

        //Методы, которые просто возвращают значения 
        public int GetTotal()
        {
            return _total;
        }

        public int GetMissed()
        {
            return _missed;
        }

        public int GetCorrect()
        {
            return _correct;
        }

        //Метод считает процент правильности ввода - "аккуратность" 
        public int GetAccuracy()
        {
            return _accuracy = 100 * _correct / (_missed + _correct);
        }

        //Метод очищает статистику
        public void ClearStats()
        {
            _total = 0;
            _missed = 0;
            _correct = 0;
            _accuracy = 0;
        }
    }
}
