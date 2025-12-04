# AWSnippets
A package to build OneStream's snippets

Download it from https://awsoftware.blob.core.windows.net/packages/AWSnippets.zip

ChangeLog is here: https://awsoftware.blob.core.windows.net/packages/AWSnippets_CHANGELOG.md

## How snippets are organized
blah - the fixed names

## Directory Structure
blah

## File format
Valid files are .cs or .vb 

The first three lines are triple slash comments:

- The first line represent the snippet's name
- The second line represent the snippet's description
- The third line contains the comma separated search terms

The fourth line should be blank

The snippet starts at the fifth line

Example:

    /// Snippet Name
    /// Snippet description
    /// Term1, Term2, Term3

    string s = "";

