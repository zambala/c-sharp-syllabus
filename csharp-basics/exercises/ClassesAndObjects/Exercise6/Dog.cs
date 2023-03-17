namespace Exercise6
{
    public class Dog
    {
        public string _name;
        private string _sex;
        private string _mother;
        private string _father;

        public Dog(string name, string sex, string mother, string father)
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
            _mother = "Unknown";
            _father = "Unknown";
        }

        public string FathersName()
        {
            return _father;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return _mother == otherDog._mother;
        }
    }
}
