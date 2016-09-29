//This program output Hello World, from line X!, where X is the line number, in the source code, of the actual print statement itself.
//cerner_2^5_2016
#include <iostream>
#include <utility>
#include <type_traits>

#define __(A,B,C,...) B##C##A
#define _(A,...) __(__VA_ARGS__, A)
template<unsigned...Is> struct v;
template<unsigned I0, unsigned... Is> struct v<I0, Is...>:v<I0-1,I0-1, Is...> {};
template<unsigned...Is> struct v<0,Is...>:std::integral_constant<unsigned, sizeof...(Is)> {};

int main() {
  std::cout << "Hello world from line " << v<_(EXTRACT,_(Q,_,E,_,$$main$$,),_(@22,,_,_),_(Z,N,L,I,_,,L),__STACK_TRACE__)>::value << "\n";
}