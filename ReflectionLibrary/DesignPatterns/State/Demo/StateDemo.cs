using ReflectionLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ReflectionLibrary.DesignPatterns.State.Demo
{
    public class StateDemo : IDemo, IDemoDescription
    {
        public string Title { get; set; } = "State";
        public string Description { get; set; } = "A pattern in which the object's behaviour is determined bu its state. An object transitions from one state to another (somthing needs to trigger a transition). A formalized construct which manages state and transitions is called a state machine";

        private static Dictionary<State, List<(Trigger, State)>> rules =
            new Dictionary<State, List<(Trigger, State)>>
            {
                [State.OffHook] = new List<(Trigger, State)>
                {
                    (Trigger.CallDialied, State.Connecting)
                },
                [State.Connecting] = new List<(Trigger, State)>
                {
                    (Trigger.HungUp, State.OffHook),
                    (Trigger.CallConnected, State.Connected)
                },
                [State.Connected] = new List<(Trigger, State)>
                {
                    (Trigger.LeftMessage, State.OffHook),
                    (Trigger.HungUp, State.OffHook),
                    (Trigger.PlaceOnHold, State.OnHold)
                },
                [State.OnHold] = new List<(Trigger, State)>
                {
                    (Trigger.TakenOffHold, State.Connected),
                    (Trigger.HungUp, State.OffHook)
                }
            };
        public void Run()
        {
            var state = State.OffHook;
            while (true)
            {
                WriteLine($"The phone is currently {state}");
                WriteLine($"Select a trigger: ");

                for (int i = 0; i < rules[state].Count; i++)
                {
                    var (t, _) = rules[state][i];
                    WriteLine($"{i}. {t}");
                }

                int input = int.Parse(Console.ReadLine());

                var (_, s) = rules[state][input];
                state = s;
            }
        }

    }
}
