using System;
namespace objectsAndClasses
{
    public class Counter
    {
        //Create Counter class
        //which has an integer property
        //when creating it should have a default value 0 or we can specify it when creating
        //we can Add(number) to this counter another whole number
        //or we can Add() without parameters just increasing the counter's value by one
        //and we can Get() the current value as string
        //also we can Reset() the value to the initial value

        public int value { get; set; } = 0;
        public int InitialValue { get; set; }

        public Counter()
        {
        }

        public Counter (int initialValue)
        {
            value = initialValue;
            InitialValue = initialValue;
        }

        public void Add()
        {
            value++;
        }

        public void Add(int valueToAdd)
        {
            value += valueToAdd;
        }

        public string Get()
        {
            return value.ToString();
        }

        public void Reset()
        {
            value = InitialValue;
            Console.WriteLine($"The value has been reset to the initial value of {value}");
        }
    }
}
