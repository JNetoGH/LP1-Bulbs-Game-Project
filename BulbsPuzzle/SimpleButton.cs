using BulbsPuzzle.Interfaces;

namespace BulbsPuzzle
{
    class SimpleButton: IBulbButton
    {
        private Bulb _bulb;
        public SimpleButton(Bulb bulb) => _bulb = bulb;
        public void Press() => _bulb.SwitchState();
    }
}