using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Curs.Model.FMS.Class
{
    public class FSM
    {
        public string _alphabet { get; set; }
        public string[] _states { get; set; }
        public string _startState { get; set; }
        public string[] _finiteStates { get; set; }
        public Dictionary<string, Dictionary<string, string>> _transitions { get; set; }
        public string currentState { get; set; }
        public FSM(string alphabet, string[] states, string startState, string[] finiteStates, Dictionary<string, Dictionary<string, string>> transitions)
        {
            _alphabet = alphabet;
            _states = states;
            _startState = startState;
            _finiteStates = finiteStates;
            _transitions = transitions;
            currentState = null;
        }
        public bool CheckIsBelongAlphabet(char symbol)
        {
            foreach (char str in _alphabet)
            {
                if (str == symbol)
                    return true;
            }
            return false;
        
        }
        public bool ChangeState(char symbol)
        {
            if (_transitions.ContainsKey(currentState) && _transitions[currentState].ContainsKey(Char.ToString(symbol)))
            {
                currentState = _transitions[currentState][Char.ToString(symbol)];
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Start(string value)
        {
            currentState = _startState;

            foreach(char  symbol in value)
            {
                if (CheckIsBelongAlphabet(symbol))
                {
                    ChangeState(symbol);
                }
                else
                {
                    return false;
                }
            }
            return CheckArray(currentState);
        }
        public bool CheckArray(string currentState)
        {
            foreach (string str in _finiteStates)
            {
                if (str == currentState)
                {
                    return true;
                }
            }
            return false;
        }
    }

}


