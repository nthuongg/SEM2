<?php

$nameErr = $emailErr = $websiteErr = $genderErr = '';
$name = $email = $website = $comment = $gender = '';

function test_input($data) {
    $data = trim($data);
    $data = stripslashes($data);
    $data = htmlspecialchars($data);
    return $data;
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {

    if (empty($_POST["name"])) {
        $nameErr = "Name is required";
    } else {
        $name = test_input($_POST["name"]);
    }

    if (empty($_POST["email"])) {
        $emailErr = "Email is required";
    } else {
        $email = test_input($_POST["email"]);
    }

    if (empty($_POST["website"])) {
        $websiteErr = "Website is required";
    } else {
        $website = test_input($_POST["website"]);
    }

    if (empty($_POST["comment"])) {
        $comment = "";
    }else {
        $comment = test_input($_POST["comment"]);
    }

    if (empty($_POST["gender"])) {
        $genderErr = "Gender is required";
    }else {
        $gender = test_input($_POST["gender"]);
    }

}

?>

<html>
<head>
    <style>
        .error {color: #FF0000;}
    </style>
</head>
<body>
<form method = "post" action = "<?php
echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
    <table>
        <tr>
            <td>Name:</td>
            <td><input type = "text" name = "name" required>
                <span class = "error">* <?php echo $nameErr;?></span>
            </td>
        </tr>

        <tr>
            <td>E-mail: </td>
            <td><input type = "email" name = "email" required>
                <span class = "error">* <?php echo $emailErr;?></span>
            </td>
        </tr>

        <tr>
            <td>Website:</td>
            <td> <input type = "url" name = "website" required>
                <span class = "error">* <?php echo $websiteErr;?></span>
            </td>
        </tr>

        <tr>
            <td>Comment:</td>
            <td> <textarea name = "comment" rows = "5" cols = "40"></textarea></td>
        </tr>

        <tr>
            <td>Gender:</td>
            <td>
                <input type = "radio" name = "gender" value = "female" checked>Female
                <input type = "radio" name = "gender" value = "male">Male
                <span class = "error">* <?php echo $genderErr;?></span>
            </td>
        </tr>

        <td>
            <input type = "submit" name = "submit" value = "Submit">
        </td>

    </table>

</form>

<?php
echo "<h2>Your given values are as:</h2>";
echo $name;
echo "<br>";

echo $email;
echo "<br>";

echo $website;
echo "<br>";

echo $comment;
echo "<br>";

echo $gender;
?>

</body>

</html>


