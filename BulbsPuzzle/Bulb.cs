using BulbsPuzzle.Enums;

namespace BulbsPuzzle
{
    class Bulb
    {
        public BulbState State { get; private set; } = BulbState.Off;
        
        public void SwitchState()
        {
            switch (State)
            {
                case BulbState.On: State = BulbState.Off; break;
                case BulbState.Off: State = BulbState.On; break;
            }
        }
        
        public override string ToString() => $"Bulb({State})";
    }
}