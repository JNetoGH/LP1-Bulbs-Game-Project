using BulbsPuzzle.Interfaces;

namespace BulbsPuzzle
{
    class SwitchButton: IBulbButton
    {
        private Bulb _bulb1;
        private Bulb _bulb2;
        
        public SwitchButton(Bulb bulb1, Bulb bulb2)
        {
            _bulb1 = bulb1;
            _bulb2 = bulb2;
        }
        
        public void Press()
        {
            if (_bulb1.State == _bulb2.State)
                return;
            _bulb1.SwitchState();
            _bulb2.SwitchState();
        }
    }
}