	using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Texts : ScriptableObject
{
	public static List<textAndPoints> texts = new List<textAndPoints>
	{
		new textAndPoints("The Gods are angry!\n\n" +
			"Proposal: Sacrifice your political opponents", 5),

		new textAndPoints("A local mobster boss demands your respect.\n\n" +
			"Proposal: Give him a seat at your council", -5),

		new textAndPoints("Murder bees are beneficial for wool production \n\n" +
			"Proposal: Release a bunch of bees in your office", -7),

		new textAndPoints("Thanks to the dry season, the farmers of you country need assistance\n\n" +
			"Proposal: Raise taxes and use the money for your own benefit", 7),

		new textAndPoints("Police brutality is on the rise \n\n" +
			"Proposal: Fire all policemen who doesn't follow your agenda", 5),

		new textAndPoints("A dead hooker was found in your summer house,\n\n" +
			"Proposal: Brag about it on national television", -15),

		new textAndPoints("Big Pharma is making big bucks on big insulin,\n\n" +
			"Proposal: Inject some big insulin yourself", -4),

		new textAndPoints("Gray aliens are contacting all the leaders of the world,\n\n" +
			"Proposal: Spend trillions to keep it a secret", 2),

		new textAndPoints("There is a circus in town. Circuses are silly.\n\n" +
			"Proposal: Shoot the clowns.", -2),

		new textAndPoints("Its your birthday and you mother is here with a gift.\n\n" +
			"Proposal: Let her in.", -5),

		new textAndPoints("A poll suggest that the public does not think your hairstyle is fashionable.\n\n" +
			"Proposal: Get a trendy haircut.", 2),

		new textAndPoints("A neighbour country is requesting financial aid.\n\n" +
			"Proposal: Pay them in exchange for vetoe in their future elections.", 10),

		new textAndPoints("A young politician is gaining on you in popularity.\n\n" +
			"Proposal: Send out a hitman to secretly kill him.", 5),

		new textAndPoints("There is a bunch of dogs running amok in the building!\n\n" + 
			"Proposal: Release a bunch of cats too.", -4),

		new textAndPoints("There is a man here trying to sell carpets.\n\n" +
			"Proposal: We tell him to get the hell out of here", 1),
	};

}

public struct textAndPoints
{
	public string text;
	public int point;

	public textAndPoints(string _text, int _points)
	{
		this.text = _text;
		this.point = _points;
	}
}
