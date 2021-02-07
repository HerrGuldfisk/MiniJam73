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

		new textAndPoints("Your political opponents had a secret party where the corona viras was spread\n\n" +
			"Proposal: Make an official statement shaming them about their irresponsibility", 5),

		new textAndPoints("A welfare organisation is offering their support\n\n" +
			"Proposal: Accept it", 2),

		new textAndPoints("A big tech company is interested in working with you\n\n" +
			"Proposal: Pay them in exchange for big data about public opinion", 6),

		new textAndPoints("People in urban outskirts are starting to doubt your ideology\n\n" +
			"Proposal: Support a local newspaper to write good things about you", 3),

		new textAndPoints("A third world country discovered rich oil reserves\n\n" +
			"Proposal: Give them financial aid in exchange for the right to use it", 6),

		new textAndPoints("Your T-shirt is back and forth\n\n" +
			"Proposal: Turn it around", 1),

		new textAndPoints("Someone dropped a cup of cofee on your office floor\n\n" +
			"Proposal: have a servant lick it up", 0),

		new textAndPoints("A war has ended between two foreign countries\n\n" +
			"Proposal: Go in and take control of them both", 6),

		new textAndPoints("A loophole was discovered in the laws deciding the precidential election\n\n" +
			"Proposal: Abuse it to extend your time as president", 12),

		new textAndPoints("The worlds wealthiest woman invites you to her private party\n\n" +
			"Proposal: Attend", 3),

		new textAndPoints("Memes are popular\n\n" +
			"Proposal: Put your best media team on posting one to show that you are in the loop", 1),

		new textAndPoints("There is money left in this years budget\n\n" +
			"Proposal: Spend it on bonuses for everyone in your party", -5),

		new textAndPoints("People are storming the presidential building!\n\n" +
			"Proposal: Listen to what they have to say", -4),

		new textAndPoints("A smaller city was bombed unexpectedly\n\n" +
			"Proposal: Make an aggressive reactive attack using nuclear missiles", -10),

		new textAndPoints("People are demostrating about systemic racism\n\n" +
			"Proposal: Take down some white people to compensate", -8),

		new textAndPoints("A foreign country is requesting access to the nuclear codes\n\n" +
			"Proposal: Give it to them", -12),

		new textAndPoints("Your chef sat the kitchen on fire\n\n" +
			"Proposal: Throw him into the soup", -1),

		new textAndPoints("More and more youngsters are ditching class\n\n" +
			"Proposal: Remove the concept of schooling", -4),

		new textAndPoints("The environment is fucked\n\n" +
			"Proposal: Ignore it and focus on what matters here and now", 9),

		new textAndPoints("Someone hacked into our databases!\n\n" +
			"Proposal: Impulsively burn the archives", -2),

		new textAndPoints("Today is the world official dancing day\n\n" +
			"Proposal: Go for a night out with the boys", -4),
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
