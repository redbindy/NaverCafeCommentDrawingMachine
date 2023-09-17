using System.Collections.Generic;

namespace NaverCafeCommentDrawingMachine
{
    public class DrawingManager
    {
        private const int CAPACITY = 256;

        private static DrawingManager mInstance;
        public static DrawingManager Instance
        { 
            get
            {
                if (mInstance == null)
                {
                    mInstance = new DrawingManager();
                }

                return mInstance;
            }
        }

        public List<User> Winners { get; private set; }

        private DrawingManager()
        {
            Winners = new List<User>(CAPACITY);
        }

        public bool login(string otpNumber)
        {
            return false;
        }
    }

}