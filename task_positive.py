def poly_string(a, b, c):
    # if all three are 0
    if a == 0 and b == 0 and c == 0:
        return "0"

    # initialize an empty string
    ans = ""

    # if a is 0 then ignore
    # if a > 1 then write 'a' then x^2
    # if a is 1 then just write x^2
    if a == 1:
        ans += "x^2"
    elif a > 1:
        ans += str(a) + "x^2"

    # if b is 0 then ignore
    # else process. you may need to add a ' + ' if a > 0
    if b > 0:
        # add '+' if a > 0
        if a > 0:
            ans += " + "

        # now process b
        if b == 1:
            ans += 'x'
        # else b is > 1
        else:
            ans += str(b) + 'x'

    # if c > 0 then write c
    if c > 0:
        # if a or b is greater than 0 then they appear before c. so we have to add a '+'
        # if a is 0, b > 0, then bx + c
        # if a > 0, b == 0. then ans has ax^2 in it.
        # if a > 0 and b > 0, then ans is now ax^2 + bx
        if a or b:
            ans += " + "
        if c:
            ans += str(c)

    return ans


if __name__ == "__main__":
    x = int(input("Angi koefficient foran x^2: "))
    y = int(input("Angi koefficient foran x: "))
    z = int(input("Angi konstantterm: "))

    print("Ditt polynom er " + poly_string(x, y, z) + ".")

    # test cases to check roughly
    # print(poly_string(3, 7, 10))
    # print(poly_string(0, 16, 0))
    # print(poly_string(1, 1, 1))
    # print(poly_string(0, 0, 0))

