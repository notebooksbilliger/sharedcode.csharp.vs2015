# Shared Code for Visual Studio 2015
Collection of shared utility code and extensions for use within your projects without the need to consider ownership.

## Purpose
Every programmer knows about writing the (almost) same utility code over and over again, and how hard it is to
maintain such code when everyone just does a Copy&Paste and applies customizations.

## Types of code

### Extensions
Extensions add functionality to existing classes (<code>static</code> members appearing as instance members).

### Utilities
Static classes containing no functionality but rather serving as an '_enum_' for available values and options for
<code>string</code> type constants, ideally including the according documentation.

## Usage
- Go to the location of your Visual Studio solution and create a folder named <code>\<Solution name>.Shared</code>.
- Go to the new folder and issue <code>git clone \<path to this repo></code>.

git will clone this repo and therefore provide you with the current version of all source files. If the repo is updated,
you keep your version of all files until you are ready to do a <code>git fetch</code>/<code>git pull</code>.

Use the files by adding them as linked items wherever needed. They will be added to the source control of your choice
without the need to point to the original repo and therefore can be shared with whoever you want.

### Unit Testing
All utilities have the <code>[ExcludeFromCodeCoverage()]</code> attribute, so when testing in your project with default
settings, they won't appear as _uncovered_ or _partially uncovered_.

Apart from that, by default, you won't be able to test them anyway because everything is <code>internal</code> (also
by default, see below).

## Contributing
This repo is a git <code>submodule</code> of the main maintenance project, which includes testing.

If you feel want or need to make changes or enhancements to one of the files, __you're welcome to do so__!

However, keep in mind that if you do changes in your main project, you won't be able to commit it to
the <code>master</code> branch, and if you commit to another branch, it won't get merged to <code>master</code>
unless it still survives all tests residing in the main project (e.g. when just eliminating typos or updating
documentation).

You're invited to rather <code>clone</code> the main project and make your changes there :)

### Coding rules and conventions when contributing
- General
  - In descriptions, documentation or any other text that is intended to be read by others, use correct spelling and interpunctuation.
  - Make your classes <code>internal</code> (internals are visible to the main test project!).
  - Make your classes <code>partial</code>.
  - Apply the <code>[ExcludeFromCodeCoverage()]</code> attribute on <code>class</code> level (Code Coverage will be collected for them anyway in the main test project!).
  - Put each class in it's own file. Name the file exactly the same as the class (i.e. choose the correct class name already on file addition).
  - __All__ documentation must reside in the code files, using the Visual Studio XML documentation features.
  - __Don't reinvent the wheel.__ Create code only if there's absolutely nothing else available in the Framework. If you discover your functionality is already available elsewhere,
    - Deprecate the code using the <code>[Obsolete()]</code> attribute and supplying a <code>message</code> _that tells others where to find the alternative_!
      - Append the following text to the <code>message</code>: <code>" This method is no longer subject to testing."</code>
    - Remove any tests code for the deprecated code.
  - Embrace standards wherever possible.

- When creating extensions
  - Put your class in the same <code>namespace</code> as the class you're extending.
  - Name the extension class <code>\<Extended class name>Ext</code>.

- When creating utility classes
  - Put your class in an existing <code>namespace</code> that is '_close_' to other classes which cover about the same topic.
