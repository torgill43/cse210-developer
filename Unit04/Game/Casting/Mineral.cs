namespace Unit04.Game.Casting
{
    // TODO: Implement the Artifact class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Actor class.
    class Mineral : Actor {

        /// <summary>
        /// <para>A mineral that has inherent value.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a message about itself.
        /// </para>
        /// </summary>
        private int _value;


    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
        public Mineral (){
            _value = 0;
        }


    // 3) Create the GetMessage() method. Use the following method comment.

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message as a string.</returns>
        public int GetValue() {
            return _value;
        }

    // 4) Create the SetMessage(string message) method. Use the following method comment.

        /// <summary>
        /// Sets the artifact's message to the given value.
        /// </summary>
        /// <param name="message">The given message.</param>
        public void SetValue(int value) {
            _value = value;
        }
    }
}