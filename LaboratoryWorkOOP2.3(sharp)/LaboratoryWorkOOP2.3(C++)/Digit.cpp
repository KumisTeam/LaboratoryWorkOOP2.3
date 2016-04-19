#include "stdafx.h"
#include "Digit.h"


Digit::Digit()
{
}


Digit::~Digit()
{
}

Digit::Digit(string usrString)
{
	for (int i = 0; i < usrString.size(); i++)
	{
		string tmp = usrString.substr(i, i);
		digits.push_back(atoi(tmp.c_str()));
	}
}

void Digit::DeleteSmth()
{
	for (int i = 0; i < digits.size() - 1; i++)
		if (digits[i] == 5)
			swap(digits[i], digits[i + 1]);
	digits.pop_back();
	for (int i = 0; i < digits.size() - 1; i++)
		if (digits[i] == 5)
			DeleteSmth();
	Show();
}

int Digit::GetSize()
{
	return digits.size();
}

void Digit::Show()
{
	for each (int var in digits)
		cout << var;
	cout << endl;
}