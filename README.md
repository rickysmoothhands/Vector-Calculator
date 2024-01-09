# Vector Calculator - Handout

### Points
150 (+50 pt. Extra Credit Opportunity)

---

### Due Date
???? ??th, 2024

---

### Goal
To create a C# class capable of representing Vectors and performing the Vector operations that we learn about in class.

---

### Learning Targets
- Recognize vector quantities as having both magnitude and direction. Represent vector quantities by directed line segments, and use appropriate symbols for vectors and their magnitudes (e.g., v, |v|, ||v||, v).
- Find the components of a vector by subtracting the coordinates of an initial point from the coordinates of a terminal point.
- Solve problems involving velocity and other quantities that can be represented by vectors.
- Add vectors end-to-end, component-wise, and by the parallelogram rule. Understand that the magnitude of a sum of two vectors is typically not the sum of the magnitudes.
- Given two vectors in magnitude and direction form, determine the magnitude and direction of their sum.
- Understand vector subtraction v – w as v + (–w), where –w is the additive inverse of w, with the same magnitude as w and pointing in the opposite direction. Represent vector subtraction graphically by connecting the tips in the appropriate order, and perform vector subtraction component-wise.
- Represent scalar multiplication graphically by scaling vectors and possibly reversing their direction; perform scalar multiplication component-wise, e.g., as c(vx, vy) = (cvx, cvy).
- Compute the magnitude of a scalar multiple cv using ||cv|| = |c|v. Compute the direction of cv knowing that when |c|v ≠ 0, the direction of cv is either along v (for c > 0) or against v (for c < 0).

---

### Instructions
Start by creating a C# class that represents a 3D Vector. This must have an X, a Y, and a Z (think about what data type best represents these: An int? A float? A string? A bool? Could you use an array for this?). After you do this, you must create a constructor that creates a Vector given the values. Then, you must override the ToString() method to allow the user to print the Vector using the format “[x, y, z]”. After you confirm that this works, create methods for each of the math concepts we learned in class. The following are cases you must make methods for (the grading/milestones). There are a total of 12 methods you need to implement.

---

### Grading Rubric
You will be graded based on how your code performs under the following conditions. It will be checked against various tests. It is recommended that you do some of your own testing before submission, more will be explained below.

#### [150 pts.] Required
- [10] Vector class with Constructor
- [10] ToString() override
- [10] const Zero & One vectors
- [10] Addition
- [10] Negation
- [10] Subtraction
- [10] Scaling
- [10] Magnitude
- [10] Normalization
- [10] Dot Product
- [10] Cross Product
- [10] Angle Between
- [10] Projection
- [10] Reflection
- [10] Equals

#### [+50 pts.] Extra Credit
- [+10] Use of proper keywords and accessibility modifiers (readonly, const, public, private, etc.)
- [+10] Null Checking or use of structs to avoid null possibility.
- [+10] Use of properties to make retrieving values easier.
- [+10] Support for any sized Vector (2D, 3D, 4D, etc.)
- [+10] Operator overrides for Add, Invert, Subtract, Scale, and Equals

---

### Testing
In order to ensure your code is correct before submission, these tests have been writen. If each one passes your code, then you should be good.

#### Variables
- a = **[ -3, 2, 7 ]**
- b = **[ 5, 0, -10 ]**
- c = **[ 8, -12, 4 ]**

#### Addition
- a + b = **[ 2, 2, -3 ]**
- b + c = **[ 13, -12, -6 ]**

#### Dot Product
- a * c = **x**
- b * c = **y**

#### Negation
- -b = **[ -5, 0, 10 ]**
- -c = **[ -8, 12, -4 ]**

#### Cross Product
- a x c = **[]**
- a x b = **[]**

#### Subtraction
- b - a = **[]**
- c - a = **[]**

#### Angle Between
- a ∠ b = **x° or y rad**
- b ∠ c = **x° or y rad**

#### Scaling
- a * 4 = **[]**
- c * -2 = **[]**

#### Projection
- proj ab = **[]**
- proj bc = **[]**

#### Magnitude
- |a| = **x**
- |b| = **y**

#### Reflection
- refl ba = **[]**
- refl cb = **[]**

#### Normalization
- b = **[]**
- c = **[]**

#### Equals
- a = b: **false**
- c = c: **true**
