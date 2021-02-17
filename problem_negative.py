'''
NOTE: str(abs(number)) has been used. we have handled the sign handling by ourselves
but str(number) handles minus by itself, so, we are using abs()
we are not using str()'s function of handling minus as we have custom spacing to do
e.g: ax^2 - bx
str() will not allow us to write `- b`
'''


def poly_string(a, b, c):
    # if all three are 0
    if a == 0 and b == 0 and c == 0:
        return "0"

    # initialize an empty string
    ans = ""

    # if a is 0 then ignore
    # if abs(a) > 1 then write ;a' then x^2
    # if abs(a) is 1 then just write x^2
    # now let's handle negative. if negative then ad a minus at the start of the string 'ans'
    if a != 0:
        # if positive then sign should be empty
        # else it will be '-'
        sign = ""
        if a < 0:
            sign = "-"

        if abs(a) == 1:
            ans += sign + "x^2"
        elif abs(a) > 1:
            ans += sign + str(abs(a)) + "x^2"

    # if b is 0 then ignore
    # else process. you may need to add a '+' or '-' if a is non-zero
    # if be is negative then the sign will be '-' else '+'
    if b != 0:
        sign = ""

        # a exists, so let the sign be '+'
        # we will change it later if necessary
        if a != 0:
            sign = " + "

        # if b is negative then change the sign into '-'
        if b < 0:
            sign = " - "

        # process b
        if abs(b) == 1:
            ans += sign + "x"
        else:
            ans += sign + str(abs(b)) + 'x'

    # if c > 0 then write c
    if c != 0:
        # if a or b is non-zero then they appear before c. so we have to add a '+' or '-'
        # depending on the sign if c
        sign = ""
        if a != 0 or b != 0:
            sign = " + "
        # if c is negative then make the sign '-'
        if c < 0:
            sign = " - "

        ans += sign + str(abs(c))

    return ans


if __name__ == "__main__":
    x = int(input("Angi koefficient foran x^2: "))
    y = int(input("Angi koefficient foran x: "))
    z = int(input("Angi konstantterm: "))

    print("Ditt polynom er " + poly_string(x, y, z) + ".")

    # test cases to check roughly
    # print(poly_string(-26, -5, -9))
    # print(poly_string(-1, -1, -1))
    # print(poly_string(-13, 8, 0))
    # print(poly_string(20, -5, 44))
