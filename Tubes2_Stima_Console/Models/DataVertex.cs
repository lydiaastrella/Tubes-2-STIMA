using GraphX.PCL.Common.Models;

namespace Tubes2_Stima_Console.Models
{
    /* DataVertex is the data class for the vertices. It contains all custom vertex data specified by the user.
     * This class also must be derived from VertexBase that provides properties and methods mandatory for
     * correct GraphX operations.
     * Some of the useful VertexBase members are:
     *  - ID property that stores unique positive identfication number. Property must be filled by user.
     *  
     */

    public class DataVertex: VertexBase
    {
        /// <summary>
        /// Some string property for example purposes
        /// </summary>
        public int NomorRumah { get; set; }
        public int Level { get; set; }

        /// <summary>
        /// Default parameterless constructor for this class
        /// (required for YAXLib serialization)
        /// </summary>
        public DataVertex():this(0)
        {
        }

        public DataVertex(int _NomorRumah = 0)
        {
            this.NomorRumah = _NomorRumah;
            this.Level = 0;
        }
        
        public int ToInt()
        {
            return this.NomorRumah;
        }
    }
}
