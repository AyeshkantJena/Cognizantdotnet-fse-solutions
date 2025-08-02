import React from 'react';

function BlogDetails() {
  const blogs = [
    {
      title: "React Learning",
      author: "Stephen Biz",
      content: "Welcome to learning React!"
    },
    {
      title: "Installation",
      author: "Schwezdenier",
      content: "You can install React from npm."
    }
  ];

  return (
    <div style={{ textAlign: 'left', padding: '10px' }}>
      <h2>Blog Details</h2>
      {blogs.map((blog, index) => (
        <div key={index} style={{ marginBottom: '15px' }}>
          <strong style={{ fontSize: '18px' }}>{blog.title}</strong><br />
          <em>{blog.author}</em><br />
          <p>{blog.content}</p>
        </div>
      ))}
    </div>
  );
}

export default BlogDetails;
