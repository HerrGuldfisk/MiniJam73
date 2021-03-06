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
			"Proposal: Brag about it on national television", -10),

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

		new textAndPoints("Your political opponents had a secret party where the corona virus was spread\n\n" +
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

		new textAndPoints("Someone dropped a cup of coffee on your office floor\n\n" +
			"Proposal: have a servant lick it up", 0),

		new textAndPoints("A war has ended between two foreign countries\n\n" +
			"Proposal: Go in and take control of them both", 6),

		new textAndPoints("A loophole was discovered in the laws deciding the precidential election\n\n" +
			"Proposal: Abuse it to extend your time as president", 10),

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

		new textAndPoints("A social media platform is used to criticise your reign \n\n" +
			"Proposal: Ban that platform", 6),

		new textAndPoints("Religious leaders want to join forces with you \n\n" +
					"Proposal: Arrange a meeting with them", -7),

		new textAndPoints("Journalists are questioning your competence \n\n" +
					"Proposal: Behead a journalist to set an example", 2),

		new textAndPoints("There are rumours of a military coup \n\n" +
					"Proposal: Build a private army", 10),

		new textAndPoints("Your resemblance to a fictional character is mocked online \n\n" +
					"Proposal: Ban fictional characters", 0),

		new textAndPoints("A musician has written a diss track aimed at you \n\n" +
					"Proposal: Write a diss track answer", -4),

		new textAndPoints("A journalist is writing a hit piece on you \n\n" +
					"Proposal: Throw a party and invite the journalist", -5),

		new textAndPoints("Public opinion is plumeting.\n\n" +
			"Proposal: Pretend like nothing", -3),

		new textAndPoints("Oil prices are on the rise!\n\n" +
			"Proposal: Conduct a \"friendly\" inspection in neighbouring countries.", 5),

		new textAndPoints("The nuclear warhead reserve is getting low.\n\n" +
			"Proposal: Construct more nuclear power plants, \"cheaper electricity for the poeple!\"", 6),

		new textAndPoints("The grandkids are visiting\n\n" +
			"Proposal: Bond with the family", -2),

		new textAndPoints("Your term is coming to an end.\n\n" +
			"Proposal: Rally the extrimists with hope of free guns", 3),

		new textAndPoints("Your Cholesterol levels are getting dangerously high.\n\n" +
			"Proposal: Ignore the doctors", -3),

		new textAndPoints("Inhabitants have started saving money in their mattresses.\n\n" +
			"Proposal: Confiscate all beds", 5),

		new textAndPoints("Scientists want more money to research guns.\n\n" +
			"Proposal: It's all about the sentiment, give them a dollar each", -4),

		new textAndPoints("Inhabitants are complaining about lack of jobs.\n\n" +
			"Proposal: Divert attention, approve hallucinogens", 10),

		new textAndPoints("AI has started taking over the world.\n\n" +
			"Proposal: Trick AI into mining bitcoins", 5),

		new textAndPoints("Protesters have started blocking the roads.\n\n" +
			"Proposal: Take your private helicopter to work", 0),

		new textAndPoints("The democratic party is pushing for impeachment!\n\n" +
			"Proposal: Sue them for coveting power", 8),

		new textAndPoints("Paparazzi published pictures of you stealing from homeless.\n\n" +
			"Proposal: Send extra pictures from better angles", -5),

		new textAndPoints("Composers want to write a new national anthem.\n\n" +
			"Proposal: Send them your mixtape, \"Velcro, what a rip-off\"", 3),

		new textAndPoints("The average salary is going down.\n\n" +
			"Proposal: Introduce SMS loans", 4),

		new textAndPoints("Assistant: Something urgent.\n\n" +
			"Proposal: Put in pile on right", 3),

		new textAndPoints("Occultism is popular.\n\n" +
			"Proposal: Sacrifice a goat", 1),

		new textAndPoints("Earth is dying.\n\n" +
			"Proposal: Send people into the sun", -4),

		new textAndPoints("Sand is blowing in from across the seas.\n\n" +
			"Proposal: Ban sand", 1),
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
