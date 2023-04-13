import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CalculatorService {
  private DEFAULT_DELIMITER = ',';
  private NEW_LINE_REGEX = /[\n]/g;
  private CUSTOM_DELIMITER_REGEX = /\/\/(.+)\n/;

  constructor() { }

  add(numbers: string): number {
    // Check for empty string
    if (!numbers) {
      return 0;
    }

    // Check for custom delimiter
    let delimiter = ",";
    if (numbers.startsWith("//")) {
      const delimiterIndex = numbers.indexOf("\n");
      if (delimiterIndex !== -1) {
        delimiter = numbers.substring(2, delimiterIndex);
        numbers = numbers.substring(delimiterIndex + 1);
      }
    }

    // Replace new lines with delimiter
    numbers = numbers.replace(/\n/g, delimiter);

    // Split the string by delimiter
    const numberArr = numbers.split(delimiter);

    let sum = 0;
    const negatives = [];
    for (const num of numberArr) {
      const parsedNum = parseInt(num, 10);
      if (isNaN(parsedNum)) {
        continue;
      }
      if (parsedNum < 0) {
        negatives.push(parsedNum);
      }
      sum += parsedNum;
    }

    if (negatives.length > 0) {
      throw new Error(`Negatives not allowed: ${negatives.join(", ")}`);
    }

    return sum;
  }
}
