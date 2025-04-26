namespace lab2_3;

static class Program {
    static void Main() {
        TextContainer text = new([
            "Lorem  ipsum dolor       sit amet consectetur    adipiscing elit .",
            "Consectetur adipiscing elit quisque faucibus ex sapien vitae.        ",
            "      Ex sapien vitae pellentesque sem placerat in id."
        ]);
        text[1].RemovePostfixWhiteSpace();
        text[2].RemovePrefixWhiteSpace();
        Console.WriteLine($"{text}\n------------------------");
        text.Append(new TextLine("    Placerat    in  id cursus mi pretium tellus duis ."));
        text.Append("Hello");
        text.RemoveLine(4);
        text.RemoveExtraSpaces();
        Console.WriteLine(text);
        Console.WriteLine($"Number of lines: {text.LineCount}, number of characters: {text.CharCount}, consonants ratio: {text.ConsonantRatio()}, the shortest line is:\n{text.GetShortestLine()}");
        Console.WriteLine("------------------------");
        TextLine line1 = new("eehhh");
        Console.WriteLine($"Consonant ratio: {line1.ConsonantRatio()}");
        TextContainer otherText = new([line1,new TextLine("wwu")]);
        Console.WriteLine($"Consonant ratio: {otherText.ConsonantRatio()}, number of characters: {otherText.CharCount}");
        Console.WriteLine(otherText + ["hello","world"]);
        otherText.Clear();
        Console.WriteLine(otherText);
    }
}