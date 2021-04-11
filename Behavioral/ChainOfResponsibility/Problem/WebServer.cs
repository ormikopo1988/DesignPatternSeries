namespace ChainOfResponsibility.Problem
{
    public class WebServer
    {
        /// <summary>
        /// Now we are tightly coupled to Authenticator, Logger & Compressor concrete implementations.
        /// We could extract interfaces for each one of them and pass them as parameters through WebServer
        /// constructor, in order to be decoupled from the above specific implementations. 
        /// Even with this approach, however, the order of these actions will be hardcoded inside this class.
        /// If in the future we want to disable logging for certain scenarios, we cannot do so, we have
        /// to come back here and change the code in this class. Even if we want to add a new step 
        /// in the process like encryption, we need again to come back in this class and change this code.
        /// This is the problem that Chain of Responsibility solves.
        /// </summary>
        /// <param name="httpRequest"></param>
        public void Handle(HttpRequest httpRequest)
        {
            // 1. Authentication task
            var authenticator = new Authenticator();
            authenticator.Authenticate(httpRequest);

            // 2. Logging task
            var logger = new Logger();
            logger.Log(httpRequest);

            // 3. Compression task
            var compressor = new Compressor();
            compressor.Compress(httpRequest);
        }
    }
}
