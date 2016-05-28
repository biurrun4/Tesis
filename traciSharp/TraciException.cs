namespace traci
{
    using System;
    /**
    * An exception in the TraCI protocol.
    * @author Enrico Gueli &lt;enrico.gueli@polito.it&gt;
    *
*/
    public class TraCIException : System.IO.IOException
    {

        /**
         * Constructor with no description.
         */
        public TraCIException() : base()
        {

        }

        /**
         * Constructor with a text description.
         * @param msg
         */
        public TraCIException(String msg) : base(msg)
        {

        }

        /**
         * A check of the response data failed.
         * @author Enrico Gueli &lt;enrico.gueli@polito.it&gt;
         *
         */
        public class UnexpectedData : TraCIException
        {
            /**
		     * 
		     * @param what a description of the checked data
		     * @param expected the expected value
		     * @param got the read value
		     */
            public UnexpectedData(String what, Object expected, Object got) : base("Unexpected " + what + ": expected " + expected + ", got " + got)
            {
            }
        }

        /**
         * The data type of a value in the response was not the expected one.
         * @author Enrico Gueli &lt;enrico.gueli@polito.it&gt;
         *
         */
        public class UnexpectedDatatype : UnexpectedData
        {
            /**
             * 
             * @param expected the expected data type
             * @param got the read data type 
             */
            public UnexpectedDatatype(int expected, int got) : base("datatype", expected, got)
            {

            }
        }
    }
}
