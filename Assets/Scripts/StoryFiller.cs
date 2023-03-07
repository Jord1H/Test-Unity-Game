using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryFiller : MonoBehaviour
{
    private static StoryNode CreateNode (string history, string[] options) {
        var node = new StoryNode {
            History = history,
            Answers = options,
            NextNode = new StoryNode[options.Length]
        };
        return node;
    }
    public static StoryNode FillStory()
    {
        var node0 = CreateNode (
            "Te encuentras en una habitacion y no recuerdas nada. quieres salir,", 
            new[] {
                "Explorar objetos",
                "Explorar habitacion"});

        var Node1 = CreateNode (
            "Te encuentras en una habitacion y no recuerdas nada. quieres salir,", 
            new[] {
                "Explorar objetos",
                "Explorar habitacion"});

        var Node9 = CreateNode (
            "Te encuentras en una habitacion y no recuerdas nada. quieres salir,", 
            new[] {
                "Explorar objetos",
                "Explorar habitacion"});

            node0.NextNode[0] = Node1;
            node0.NextNode[1] = Node9;
            return node0;
  }
}
