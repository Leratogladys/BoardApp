using System;

namespace BoardApp.Models;

public class Board
{
	public string BoardCode {  get; set; }
	public string Make {  get; set; }
	public string Model { get; set; }
	public int FlashKb { get; set; }
	public decimal Price { get; set; }

	public Board () { }

	public Board (string boardCode,  string make, string model , int flashKb, decimal price)
	{
		BoardCode = boardCode;
		Make = make;							
		Model = model;
		FlashKb = flashKb;
		Price = price;
	}


	public override string ToString()
	{
		return $"{BoardCode}: {Make} {Model} with {FlashKb} KB flash at R{Price:0.00}";
	}
}
