//cerner_2^5_2016
//Calling a function without calling it

#include <stdio.h>

int puts(const char *str) {
  fputs("Sentence I want to print!\n", stdout);
}

int main() {
  printf("Dummy String!\n");
}
