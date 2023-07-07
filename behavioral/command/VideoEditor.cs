public class VideoEditor{
    public double Contrast { get; set; }
    public string Text { get; set; }

    public VideoEditor()
    {
        Contrast = 0.5;
        Text = "";
    }

    public void RemoveText(){
        Text = "";
    }
    public override string ToString()
    {
        return "VideoEditor{" +
                "contrast=" + Contrast +
                ", text='" + Text + '\'' +
                '}';
    }
}