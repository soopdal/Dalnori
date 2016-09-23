using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I
{
    public class I
    {
        public I i = null;

        private void knowMyself()
        {
            if(i != null)
                i = new I();    
        }

        public void dontKnowMyself()
        {
            knowMyself();
        }
    }

    public class Mind
    {
        public void Move(Target target)
        {
            knowledge.know(target);
        }

        public Target       target;
        public Feeling      feeling;
        public Thinking     thinking;
        public Doing        doing;
        public Knowledge    knowledge;
    }

    public class Target : Object
    {
        public Target targeting(Object _object)
        {
            Target target = (Target)_object;
            return target;
        }
    }

    public class Object
    {

    }

    public class Feeling
    {
        public FeelState feel(Target target)
        {
            FeelState state = FeelState.Plain;
            return state;
        }

        public Mood mood;
    }

    public enum MoodState
    {
        Good,
        Plain,
        Bad
    }

    public class Mood
    {
        MoodState state = MoodState.Plain;
    }

    public enum FeelState
    {
        Good,
        Plain,
        Bad
    }

    public class Thinking
    {

    }

    public class Doing
    {

    }

    public class Knowledge
    {
        public void know(Target target)
        {

        }
    }

    public class Unconscious
    {

    }
        
    public class Body
    {

    }
}
