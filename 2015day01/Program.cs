var input = string.Join('_', args);
int currentFloor = 0;
bool hasEnteredBasement = false;
int currentPosition = 0;
int finalPosition = 0;

foreach (var character in input)
{
    switch (character)
    {
        case '(':
            currentPosition++;
            currentFloor++;
            break;
        case ')':
            currentPosition++;
            currentFloor--;
            if (!hasEnteredBasement && currentFloor < 0)
            {
                finalPosition = currentPosition;
                hasEnteredBasement = true;
            }
            break;
        default:
            break;
    }
}

Console.WriteLine($"Part One Solution: {currentFloor}");
Console.WriteLine($"Part Two Solution: {finalPosition}");