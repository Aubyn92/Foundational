using System.Collections.Generic;
using NewBlackjackProject;

namespace NewBlackjackProjectTests
{
    public class TestResponder: IInputOutput
    {
        private readonly Queue <string>_testResponses = new Queue<string>();
        
        public TestResponder(IEnumerable<string> testResponse)
        {
            foreach (var response in testResponse)
            {
                _testResponses.Enqueue(response);
            }
        }
        
        public string Ask(string question)
        {
            return _testResponses.Dequeue();
        }

        public void Output(string message)
        {
        }
    }
}
