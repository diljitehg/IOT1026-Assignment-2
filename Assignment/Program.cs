using System;

namespace Assignment
{
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        public TreasureChest()
        {
            _material = Material.Iron;
            _lockType = LockType.Expert;
            _lootQuality = LootQuality.Green;
        }

        public TreasureChest(State state) : this()
        {
            _state = state;
        }

        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }

        public State GetState()
        {
            return _state;
        }

        public void Manipulate(Action action)
        {
            switch (action)
            {
                case Action.Open:
                    Open();
                    break;
                case Action.Close:
                    Close();
                    break;
                case Action.Lock:
                    Lock();
                    break;
                case Action.Unlock:
                    Unlock();
                    break;
            }
        }

        private void Unlock()
        {
            if (_state == State.Locked)
            {
                _state = State.Closed;
            }
            else if (_state == State.Closed)
            {
                Console.WriteLine("The chest is already unlocked.");
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest cannot be unlocked because it is already open.");
            }
        }

        private void Lock()
        {
            if (_state == State.Closed)
            {
                _state = State.Locked;
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest is already locked.");
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest cannot be locked because it is already open.");
            }
        }

        private void Open()
        {
            if (_state == State.Closed)
            {
                _state = State.Open;
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest is already open.");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be opened because it is locked.");
            }
        }

        private void Close()
        {
            if (_state == State.Open)
            {
                _state = State.Closed;
            }
            else if (_state == State.Closed)
            {
                Console.WriteLine("The chest is already closed.");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be closed because it is locked.");
            }
        }

        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        public enum State { Open, Closed, Locked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron };
        public enum LockType { Novice, Intermediate, Expert };
        public enum LootQuality { Grey, Green, Purple };
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            TreasureChest chest = new TreasureChest();

            Console.WriteLine(chest); // Output: A Locked chest with the following properties: Material: Iron, Lock Type: Expert, Loot Quality: Green

            chest.Manipulate(TreasureChest.Action.Open);
            Console.WriteLine(chest.GetState()); // Output: Open

            chest.Manipulate(TreasureChest.Action.Close);
            Console.WriteLine(chest.GetState()); // Output: Closed

            chest.Manipulate(TreasureChest.Action.Lock);
            Console.WriteLine(chest.GetState()); // Output: Locked

            chest.Manipulate(TreasureChest.Action.Unlock);
            Console.WriteLine(chest.GetState()); // Output: Closed

            chest.Manipulate(TreasureChest.Action.Open);
            Console.WriteLine(chest.GetState()); // Output: Open

            chest.Manipulate(TreasureChest.Action.Lock);
            Console.WriteLine(chest.GetState()); // Output: Open (cannot be locked because it is already open)

            chest.Manipulate(TreasureChest.Action.Close);
            Console.WriteLine(chest.GetState()); // Output: Closed

            chest.Manipulate(TreasureChest.Action.Unlock);
            Console.WriteLine(chest.GetState()); // Output: Closed (cannot be unlocked because it is already closed)

            chest.Manipulate(TreasureChest.Action.Open);
            Console.WriteLine(chest.GetState()); // Output: Open

            chest.Manipulate(TreasureChest.Action.Lock);
            Console.WriteLine(chest.GetState()); // Output: Locked

            Console.WriteLine(chest); // Output: A Locked chest with the following properties: Material: Iron, Lock Type: Expert, Loot Quality: Green
        }
    }
}
