namespace Behavioral.Visitor.Exercise;

public static class VisitorExerciseDemo{
    public static void Run(){
        //do stuff
        var formatSegment = new FormatSegment();
        var fact1 = new FactSegment();
        var fact2 = new FactSegment();

        var parentWav = new WavFile();
        parentWav.Add(formatSegment);
        parentWav.Add(fact1);
        parentWav.Add(fact2);

        parentWav.Filter(new Normalize());
        parentWav.Filter(new AddReverb());
        parentWav.Filter(new ReduceNoise());
    }
}