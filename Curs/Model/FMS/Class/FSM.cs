using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs.Model.FMS.Class
{
    public class FSM
    {
        private int currentState;
        private HashSet<int> finalStates;
        private Dictionary<int, Dictionary<char, HashSet<int>>> transitions;

        public FSM()
        {
            currentState = 0;
            finalStates = new HashSet<int>();
            transitions = new Dictionary<int, Dictionary<char, HashSet<int>>>();
        }

        public void AddState(int state, bool isFinal)
        {
            if (isFinal)
                finalStates.Add(state);

            transitions[state] = new Dictionary<char, HashSet<int>>();
        }

        public void AddTransition(int fromState, char symbol, int toState)
        {
            if (!transitions.ContainsKey(fromState))
            {
                transitions[fromState] = new Dictionary<char, HashSet<int>>();
            }

            if (!transitions[fromState].ContainsKey(symbol))
            {
                transitions[fromState][symbol] = new HashSet<int>();
            }

            transitions[fromState][symbol].Add(toState);
        }

        public void Reset()
        {
            currentState = 0;
        }

        public bool Accepts(string input)
        {
            foreach (char symbol in input)
            {
                if (!transitions[currentState].ContainsKey(symbol))
                    return false;

                currentState = transitions[currentState][symbol].First();
            }

            return finalStates.Contains(currentState);
        }
    }
}

